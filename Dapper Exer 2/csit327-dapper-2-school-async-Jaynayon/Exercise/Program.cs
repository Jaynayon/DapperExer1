using DapperExer2.Models;
using DapperExer2.Repositories;

internal class Program
{
    private static async Task Main(string[] args) //Change void to Task
    {
        ISchoolRepository repository = new SchoolRepository();

        // sample printing
        //var testSchool = await repository.GetSchool(1);
        //Console.WriteLine(testSchool);
        var uv = new School
        {
            Name = "UV",
            Address = "Atbang Colonade",
            Motto = "Chill lang way assignment",
            AverageTuition = 50.32
        };
        
        //ADDS NEW SCHOOL UV AND STORES UV ID (1)
        var uvId = await repository.AddSchool(uv);
        // PRINT UV ID (2)
        Console.WriteLine("New Id: " + uvId + "\n");

        //GETS AND PRINTS THE ID OF UV (3)
        Console.WriteLine( await repository.GetSchool(uvId) + "\n");

        uv.Motto = "Way assignment, chill lang";

        //UPDATES UV MOTTO (4)
        if (await repository.UpdateSchool(uv))
            Console.WriteLine("School Motto Updated\n");
        else
            Console.WriteLine("School Motto Not Updated\n");

        //PRINTS ALL THE SCHOOLS (5)
        foreach (var school in await repository.GetAllSchools())
            Console.WriteLine(school);
        Console.WriteLine("");

        //DELETE SCHOOL UV (6)
        if (await repository.DeleteSchool(uvId))
            Console.WriteLine("School Deleted\n");
        else
            Console.WriteLine("School Not Deleted\n");

        //PRINTS ALL THE SCHOOLS (7)
        foreach (var school in await repository.GetAllSchools())
            Console.WriteLine(school);

        // TODO: Do this workflow in Main
        // 1. Add new school UV
        // 2. Print id of new school UV
        // 3. Get new school UV using id and print
        // 4. Update school UV's motto
        // 5. GetAllSchools, loop each school and print
        // 6. Delete school UV
        // 7. GetAllSchools, loop each school and print again
    }
}