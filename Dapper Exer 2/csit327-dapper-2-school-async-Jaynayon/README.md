# CSIT327 3.1 School DB Async 🏫

## Task
1. Run `SchoolDb.sql` to your local database. 
It will create an `Exer1Db` database with a `School` Table.

2. Add necessary properties for `School` Model.
3. Implement `ISchoolRepository` _**ASYNCHRONOUSLY**_.
	 - `Get(id)` - Returns single school with Id == id
	 - `GetAll()` - Returns all schools
	 - `Add(School school)` - Insert school, returns the Id of the newly inserted school.
	 - `Update(School school)` - Updates values of school with id, returns true/false if update is successful,
	 - `Delete(id)` - Deletes a school with id == id, returns if delete is successful.

4. **Follow instructions** found in `Program.cs` `Main` method for testing and printing.


----
## Resources
How to get connection string: \
https://www.c-sharpcorner.com/UploadFile/d40a40/get-sql-server-database-connection-string-easily-from-visual

Learn dapper :\
https://www.learndapper.com/

Some async examples using dapper:\
https://code-maze.com/using-dapper-with-asp-net-core-web-api/

Asynchrounous programming:\
https://www.tutorialsteacher.com/articles/asynchronous-programming-with-async-await-task-csharp
# Project Repository DO's and DONT's

## DO's ✅
1. Observe DRY. 
2. Make atomic commits. 
3. Apply good commit messages 
4. Document code. 
5. Remove code smells.
6. Remember to push final codes in master.

## DONT'S ❌
Failure to comply on the following will **automatically void your grade** in this exercise: 

1. Do NOT change function signature. 
2. Do NOT touch anything in `.github` folder. 
3. Do NOT edit README.md 
4. Do NOT modify tests in `*.Tests` project.


---
### Prepared by:
Yours Truly,

**Jhon Christian Ambrad** \
jhonchristian.ambrad@cit.edu \
+639761014328
