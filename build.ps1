﻿Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/convert -l powershell -o client -c packageconfig.json
Write-Output "Starting post-build";
& ./client/Build.ps1