# DevOps Demo App

A simple static HTML app served by Nginx in Docker.

## Run locally

1. Build the image:

   docker build -t devops-test-app .

2. Run the container on port 8080:

   docker run --rm -d -p 8080:80 --name devops-test-app-container devops-test-app

3. Open:

   http://localhost:8080

## GitHub push

If a GitHub remote is configured, push with:

   git add .
   git commit -m "Initial static site"
   git push -u origin main

If the branch is still named `master`, replace `main` with `master` or rename the branch first.
