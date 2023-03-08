{ pkgs }: {
	deps = [
		pkgs.lsb-release
  pkgs.jq.bin
  pkgs.dotnet-sdk
    pkgs.omnisharp-roslyn
	];
}