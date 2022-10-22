# COMMON PATHS
$rootFolder = (Get-Item -Path "../" -Verbose).FullName

# List of projects
$projectPaths = @(
    "aspnet-core/src/Wiyu.AuthServer",
    "aspnet-core/src/Wiyu.HttpApi.Host",
    "aspnet-core/src/Wiyu.Web",
    "angular"
)

# List of prosess
$processes = @()

foreach ($projectPath in $projectPaths) {    

    $projectAbsPath = (Join-Path $rootFolder $projectPath)
    $splittedProjectPath = $projectPath.Split('/')
    $projectName = $splittedProjectPath[$splittedProjectPath.Length - 1]
    $projectName = $projectName.Replace("Wiyu.", "")

    switch ($projectName) {
        "AuthServer" { $port = "44301" }
        "HttpApi.Host" { $port = "44300" }
        "Web" { $port = "44302" }
        "angular" { $port = "4200" }
    }
	   
    Write-Output "Running: $projectName...  ----> https://localhost:$port" 
    
   	    
    $params = "/c cd /d $projectAbsPath && title $projectName-$port"

    if ($projectName -eq "angular") {
        $params = "$params && ng serve --open"
    }
    else {
        $params = "$params && dotnet run -c Debug"
    }

    $startExe = New-Object System.Diagnostics.ProcessStartInfo
    $startExe.FileName = "cmd.exe"
    $startExe.Arguments = $params
    $startExe.WindowStyle = "Normal"


    $process = New-Object System.Diagnostics.Process
    $process.StartInfo = $startExe
    $process.Start()
    $processes += $process

	 
    if (-Not $?) {
        Write-Host ("Failed for the solution: " + $solutionPath)
        Set-Location $rootFolder
        exit $LASTEXITCODE
    }
}

Write-Output "Press enter to quit all applications..."
Read-Host

foreach ($process in $processes) {
    taskkill /F /PID $process.Id /T
}

Write-Output "All applications are closed."
