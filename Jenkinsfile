pipeline {
    agent { docker 'mcr.microsoft.com/dotnet/core/sdk:2.1' }
    environment {
        HOME = '/tmp'
    } 
    stages {
        stage('Restore NuGet Packages') {
            steps {
                sh 'pwd'
                sh 'ls'
                sh (
                    script: 'dotnet restore',
                    returnStdout: true
                )
            }
        }
    }
}