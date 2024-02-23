using JohanResumeeLabb3.Data;
using JohanResumeeLabb3.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//CREATE About
app.MapPost("/about", async (ApplicationDbContext context, About aboutme) =>
{
    context.About.Add(aboutme);
    await context.SaveChangesAsync();
    return Results.Ok(await context.About.ToListAsync());
});

//CREATE Education
app.MapPost("/education", async (ApplicationDbContext context, Education education) =>
{
    context.Educations.Add(education);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Educations.ToListAsync());
});

//CREATE Jobs
app.MapPost("/job", async (ApplicationDbContext context, Jobs job) =>
{
    context.Jobs.Add(job);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Jobs.ToListAsync());
});

//CREATE Project
app.MapPost("/project", async (ApplicationDbContext context, Projects project) =>
{
    context.Projects.Add(project);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Projects.ToListAsync());
});

//CREATE Skills
app.MapPost("/skill", async (ApplicationDbContext context, Skills skill) =>
{
    context.Skills.Add(skill);
    await context.SaveChangesAsync();
    return Results.Ok(await context.Skills.ToListAsync());
});

//READ About
app.MapGet("/about", async (ApplicationDbContext context) =>
{
    return Results.Ok(await context.About.ToListAsync());
});

//READ Educations
app.MapGet("/educations", async (ApplicationDbContext context) =>
{
    return Results.Ok(await context.Educations.ToListAsync());
});

//READ Jobs
app.MapGet("/jobs", async (ApplicationDbContext context) =>
{
    return Results.Ok(await context.Jobs.ToListAsync());
});

//READ Projects
app.MapGet("/projects", async (ApplicationDbContext context) =>
{
    return Results.Ok(await context.Projects.ToListAsync());
});

//READ Skills
app.MapGet("/skills", async (ApplicationDbContext context) =>
{
    return Results.Ok(await context.Skills.ToListAsync());
});

//UPDATE About
app.MapPut("/about", async (ApplicationDbContext context, int Id, About updateAbout) =>
{
    var aboutToUpdate = await context.About.FindAsync(Id);
    if (aboutToUpdate == null)
    {
        return Results.NotFound("Could not found this User");
    }
    aboutToUpdate.Name = updateAbout.Name;
    aboutToUpdate.LastName = updateAbout.LastName;
    aboutToUpdate.Age = updateAbout.Age;
    aboutToUpdate.Email = updateAbout.Email;
    aboutToUpdate.Phone = updateAbout.Phone;
    
    await context.SaveChangesAsync();
    return Results.Ok(await context.About.ToListAsync());
});

//UPDATE Education
app.MapPut("/education", async (ApplicationDbContext context, int Id, Education updateEducation) =>
{
    var educationToUpdate = await context.Educations.FindAsync(Id);
    if(educationToUpdate == null)
    {
        return Results.NotFound("Could not found this education");
    }
    educationToUpdate.SchoolName = updateEducation.SchoolName;
    educationToUpdate.startYear = updateEducation.startYear;
    educationToUpdate.endYear = updateEducation.endYear;
    educationToUpdate.Description = updateEducation.Description;
    
    await context.SaveChangesAsync();
    return Results.Ok(await context.Educations.ToListAsync());
});

//UPDATE Jobs
app.MapPut("/job", async (ApplicationDbContext context, int Id, Jobs updateJobs) =>
{
    var jobsToUpdate = await context.Jobs.FindAsync(Id);
    if (jobsToUpdate == null)
    {
        return Results.NotFound("Could not found this job");
    }
    jobsToUpdate.CompanyName = updateJobs.CompanyName;
    jobsToUpdate.startYear = updateJobs.startYear;
    jobsToUpdate.endYear = updateJobs.endYear;
    jobsToUpdate.roleDescription = updateJobs.roleDescription;
    jobsToUpdate.ImagePath = updateJobs.ImagePath;

    await context.SaveChangesAsync();
    return Results.Ok(await context.Jobs.ToListAsync());
});

//UPDATE Projects
app.MapPut("/project", async (ApplicationDbContext context, int Id, Projects projectUpdate) =>
{
    var projectToUpdate = await context.Projects.FindAsync(Id);
    if (projectToUpdate == null)
    {
        return Results.NotFound("Could not found this project");
    }
    projectToUpdate.Name = projectToUpdate.Name;
    projectToUpdate.Description = projectToUpdate.Description;

    await context.SaveChangesAsync();
    return Results.Ok(await context.Projects.ToListAsync());
});

//UPDATE Skills
app.MapPut("/skill", async (ApplicationDbContext context, int Id, Skills skillUpdate) =>
{
    var skillToUpdate = await context.Skills.FindAsync(Id);
    if (skillToUpdate == null)
    {
    return Results.NotFound("Could not found this skill");
    }
    skillToUpdate.Name = skillToUpdate.Name;
    skillToUpdate.Progress = skillToUpdate.Progress;

    await context.SaveChangesAsync();
    return Results.Ok(await context.Skills.ToListAsync());
});

//DELETE About
app.MapDelete("/about/{Id}", async (ApplicationDbContext context, int Id) =>
{
    var aboutToDelete = await context.About.FindAsync(Id);
    if (aboutToDelete == null)
    {
    return Results.NotFound("Could not found this user");
    }
    context.About.Remove(aboutToDelete);
    await context.SaveChangesAsync();

    return Results.Ok(await context.About.ToListAsync());
});

//DELETE Education
app.MapDelete("/education/{Id}", async (ApplicationDbContext context, int Id) =>
{
    var educationDelete = await context.Educations.FindAsync(Id);
    if(educationDelete == null)
    {
        return Results.NotFound("Could not found this education");
    }
    context.Educations.Remove(educationDelete);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Educations.ToListAsync());
});

//DELETE Jobs
app.MapDelete("/job/{Id}", async (ApplicationDbContext context, int Id) =>
{
    var jobdelete = await context.Jobs.FindAsync(Id);
    if (jobdelete == null)
    {
        return Results.NotFound("Could not found this job");
    }
    context.Jobs.Remove(jobdelete);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Jobs.ToListAsync());
});

//DELETE Project
app.MapDelete("/project/{Id}", async (ApplicationDbContext context, int Id) =>
{
    var projectDelete = await context.Projects.FindAsync(Id);
    if (projectDelete == null)
    {
        return Results.NotFound("Could not found this project");
    }
    context.Projects.Remove(projectDelete);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Projects.ToListAsync());
});

//DELETE Skill
app.MapDelete("/skill/{Id}", async (ApplicationDbContext context, int Id) =>
{
    var skillDelete = await context.Skills.FindAsync(Id);
    if (skillDelete == null)
    {
        return Results.NotFound("Could not found this skill");
    }
    context.Skills.Remove(skillDelete);
    await context.SaveChangesAsync();

    return Results.Ok(await context.Skills.ToListAsync());
});

app.Run();

