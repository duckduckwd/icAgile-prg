# GIT in 5 Minutes - Concrete Practice

## Cloning the Repository

*Your trainer will let you know the URL for you to use for your course.*
*If working in a pair or groups, only one person need do the following steps*

1. Using the command line (or GitBash) navigate to *C:/*.
2. In *gitlab*, click on the **Clone** button and copy the **HTTPS** link:

   ![GitLab Clone](../../images/gitlab2.png)
   **Note: Your url may be different**

3. Go back to your terminal and use the command:

   ```git clone <the_url_you_have_been_provided_with>```
   **Your trainer will provide you with a different address to clone, you should use that**

4. Wait for the repo to clone.
5. In your file explorer, navigate to the **repo's home** folder and remove the **.git** folder.

## Downloading the Zipped Repository

If working in a pair or groups, *only one person need do the following steps* - it can be skipped if the cloning steps have been taken

1. In *gitlab*, click on the **Download** button and then on **zip** - this should initiate download: ![GitLab Download](../../images/gitlab3.png)
2. Extract the downloaded zip folder to *C:/*.
   - This will create a folder called agile-programming-master with the required files inside it.

## Create an account on a cloud-based git server

If working in a pair or groups, *only the one of the group who cloned/unzipped* should do this

1. Create a personal account on one of the following services (or use an existing account if you have one):
   - [GitLab](https://gitlab.com)
   - [BitBucket](https://bitbucket.org)
   - [GitHub](https://github.com)

Please note that this is not an exhaustive and/or endorsed list!

## Create a shared repository for you and your partner

If working in a pair or groups, *only the one of the group who cloned/unzipped* should do this

1. In your terminal, navigate to the root folder for the repository you cloned/unzipped.
2. Initialise a **new** Git repository using the command ```git init```.
3. Stage all of the files in the repo using the command ```git add .```.
4. Commit the files with the command ```git commit -m "Initial commit"```.
5. In your cloud-based git service, create a new repository - it should be empty (not even a README.md document!).
6. Follow the steps shown to get the command to sync your cloud repo with the local one on your computer.  The command should be something like ```git remote add <someURL>```.
7. Push your local files to the remote repo using the command ```git push -u origin master```.
8. Either add your partner as an **owner/maintainer** of this repository or make it public so that they can clone and edit it.

## Get a copy of the new repository

The partner(s) who has *not yet got a copy of the repo* should do this

1. Using the command line (or GitBash) navigate to *C:/*;
2. Use the ```git clone``` command with required URL to clone your partner's repository.

### if required, open your code base in an IDE

*All of the group should do this*
The following IDEs are pre-installed on your computers for use with the code:

- VSCode
- PyCharm CE
- Visual Studio CE
- Eclipse
- IntelliJ

Using the whole repo as a project, open your code base in your preferred IDE.  If your preferred option is not in the list, feel free to download and install your own choice.

*Whole Activity Time Box:* **20 minutes**
