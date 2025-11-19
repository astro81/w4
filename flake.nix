{
  description = "Disq hybrid development environment (Nix + Docker Compose)";

  inputs = {
    nixpkgs.url = "github:NixOS/nixpkgs/nixos-unstable";
    flake-utils.url = "github:numtide/flake-utils";
  };

  outputs = { self, nixpkgs, flake-utils }:
    flake-utils.lib.eachDefaultSystem (system:
      let
        pkgs = nixpkgs.legacyPackages.${system};
      in {
        # Dev shell: reproducible tools
        devShells.default = pkgs.mkShell {
          packages = with pkgs; [
            docker-compose
            dotnet-sdk_10
          ];

          shellHook = ''
            echo "Dotnet env ready!"
            
            # create a project with Auto render mode and global interactivity
            alias carg="dotnet new blazor -o src -int Auto -ai true"   
            
            # create a project with Auto render mode and per page/component interactivity
            alias carp="dotnet new blazor -o src -int Auto -ai false"   
            
            # list the solution projects
            alias slist="dotnet sln list"
            
            # compile everything
            alias sbuild="dotnet build src.sln"
            
            #run the src.csproj (the server/host project)
            alias host-run="dotnet run --project src/src.csproj"
            
            # Enable Hot Reload
            alias watch="dotnet watch run --project src/src.csproj"

            # docker build -t src .
            # docker run --rm src

          '';
        };

        # Shortcuts to run things directly
        apps = {
          # db, cache, frontend
          up = {
            type = "app";
            program = "${pkgs.writeShellScriptBin "up" ''
              docker-compose up
            ''}/bin/up";
          };

          down = {
            type = "app";
            program = "${pkgs.writeShellScriptBin "down" ''
              docker-compose down
            ''}/bin/down";
          };

        };
      });
}

