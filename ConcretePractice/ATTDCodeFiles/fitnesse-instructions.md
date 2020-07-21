# Acceptance Test Driven Development Concrete Practice

- Work in your pairs and locate the Fitness Folder within the Acceptance Test Driven Development code files.

1. Create **Account.java** file
2. Paste contents of **pojo.txt** into it and save
3. Create **AccountFixture.java** file
4. Paste contents of **fixture.txt** into it and save
5. Open the working folder at the Command Line
6. *Compile* both java files with the following command: `javac *.java`

You will now have two .class files.

7. Remain at the command line and install and launch Fitness with the following command: `java -jar fitnesse-standalone.jar -p 8090`

Once fitness has been unpacked, the web server will be launched and open on port 8090

8. Navigate to the fitness page in your browser using: [http://localhost:8090]
9.  On the home page, click the **Edit** button
10. At the bottom of the page, enter the name **AccountTest** on a blank line and then click the **Save** button
11. You will now see the *AccountTest* name with an appended question mark hyperlink **[?]**
12. Click the **[?]** hyperlink.

The resulting *Edit* page has the following first line: `!contents -R2 -g -p -f -h`

13. Paste the contents of **wiki.txt** below this line
14. Update the line that begins `!path` with the *path to where you have stored your java files*
15. Click the **Save** button

Your page will now display a table containing three tests.

16. Click on the **Test** button at the top of the page to run your tests

You should see that two of the tests pass correctly while the third fails.  This is due to an incorrect expected value in the test.

17. Correct the test and run it again
