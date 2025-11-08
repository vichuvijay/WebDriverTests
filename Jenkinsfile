pipeline {
    agent any

    tools {
        dotnet 'dotnet6'  // name from Global Tool Configuration
    }

    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/vichuvijay/WebDriverTests.git'
            }
        }

        stage('Restore Packages') {
            steps {
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build --configuration Release'
            }
        }

        stage('Run Tests') {
            steps {
                bat 'dotnet test --logger "trx;LogFileName=test_results.trx"'
            }
        }
    }

    post {
        always {
            junit '**/TestResults/*.trx'
        }
    }
}
