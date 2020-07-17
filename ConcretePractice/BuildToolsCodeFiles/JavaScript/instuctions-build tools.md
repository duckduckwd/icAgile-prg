# Build Tools

## Task 1

Open the Calculator project into your workspace (VSCode)

Right-click on the Calculator Project -> Open in Terminal

Type `npm init -y`.  This will initiate an NPM project with the defaults set.

You should see json file (package.json) created for you automatically.

---

## Task 2

Install the following depenencies for this project.  They are there to help with unit testing.

```npm install --save-dev mocha chai```

This will install *mocha* which is a JavaScript testing framework and *chai* which is an assertion library.

You should notice that a **node_modules** folder is added to the project folder and that *mocha* and *chai* are added to the list of **development dependencis** in *package.json*.

Install **mocha** globally using the command ```npm i -g mocha```, so the command format ```mocha <filename>``` can be used to run tests in a file.
