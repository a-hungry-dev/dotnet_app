pipeline {
    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/core/sdk:2.1'
        }
    }
    stages {
        stage('ls') {
            steps {
                sh 'ls'
            }
        }
    }
}