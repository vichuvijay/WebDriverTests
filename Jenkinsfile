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
                sh 'dotnet build'
            }
        }

        stage('Run Tests') {
            steps {
                echo 'Running NUnit tests...'
                sh 'dotnet test --logger "trx;LogFileName=test_results.trx"'
            }
        }
    }

    post {
        always {
            echo 'Cleaning up workspace...'
            deleteDir()
        }
        success {
            echo 'Build and tests completed successfully ✅'
        }
        failure {
            echo 'Build or tests failed ❌'
        }
    }
}
