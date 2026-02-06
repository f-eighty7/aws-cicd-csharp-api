# 🏴‍☠️ Rövarspråket API (Rovar-App)

This is a REST API built with **.NET 9 (C#)** that automatically translates text to and from [Rövarspråket](https://en.wikipedia.org/wiki/R%C3%B6varspr%C3%A5ket) (The Robber Language).

The project was created as part of a **CI/CD** assignment focusing on automated testing, pipelines, and cloud deployment via **AWS**.

## 🚀 Live Demo & Endpoints

The application is deployed live on AWS Elastic Beanstalk. Click the links below to test the API directly:

### 🏠 Home (Base URL)

Welcome message to verify that the API is running.

* 🔗 **Link:** http://rova-app-env.eba-55anzhtu.eu-north-1.elasticbeanstalk.com/

---

## 🔌 API Documentation

Here are direct links to test the core features:

### 1. Encrypt (To Rövarspråket)

Converts standard text into Rövarspråket.

* **Test Link (Text: "hej"):**
http://rova-app-env.eba-55anzhtu.eu-north-1.elasticbeanstalk.com/encrypt?text=hej

**Expected Response:**

```json
"hohejoj"

```

### 2. Decrypt (From Rövarspråket)

Restores text from Rövarspråket back to standard text.

* **Test Link (Text: "hohejoj"):**
http://rova-app-env.eba-55anzhtu.eu-north-1.elasticbeanstalk.com/decrypt?text=hohejoj

**Expected Response:**

```json
"hej"

```

---

## 🛠️ Tech Stack

* **Framework:** .NET 9 (Minimal API)
* **Language:** C#
* **Testing:** xUnit
* **CI/CD:** GitHub Actions
* **Cloud/Hosting:** AWS Elastic Beanstalk (Linux)
* **Version Control:** Git (Git Flow strategy)

---

## ⚙️ CI/CD Pipeline

The project utilizes a fully automated pipeline via **GitHub Actions** to ensure code quality and delivery.

### Workflow (Git Flow)

1. **Pull Request (CI):** When code is pushed to a feature branch or a PR is opened against `dev`, a build process and all unit tests (`dotnet test`) are triggered. If tests fail, the merge is blocked.
2. **Merge to Main (CD):** When code is approved and merged:
* The application is built and tested again.
* `dotnet publish` creates optimized files for the Linux environment.
* The artifact is zipped.
* The code is automatically deployed to **AWS Elastic Beanstalk** using GitHub Secrets.

---