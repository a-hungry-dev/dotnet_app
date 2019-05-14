pipeline {
    agent { docker 'mcr.microsoft.com/dotnet/core/sdk:2.2' }
    environment {
        HOME = '/tmp'
    } 
    stages {
        stage('Restore NuGet Packages') {
            steps {
                dir('dotnet_app') {
                    sh (
                        script: 'dotnet restore',
                        returnStdout: true
                    )
                }
            }
        }
    }
}