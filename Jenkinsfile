pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/vichuvijay/WebDriverTests.git'
            }
        }

        stage('Build') {
            steps {
                echo 'Building the project...'
                bat 'dotnet build WebDriverTests.csproj'  // ✅ use bat for Windows
            }
        }

        stage('Run Tests') {
            steps {
                echo 'Running tests...'
                bat 'dotnet test WebDriverTests.csproj --logger:"trx;LogFileName=test_results.trx"' // ✅ Windows style
            }
        }
    }

    post {
        always {
            echo 'Cleaning up workspace...'
            deleteDir()
        }
        success {
            echo 'Build and tests succeeded ✅'
        }
        failure {
            echo 'Build or tests failed ❌'
        }
    }
}
