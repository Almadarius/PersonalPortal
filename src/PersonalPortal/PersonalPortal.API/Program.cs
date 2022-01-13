using PersonalPortal.Service.Contracts;
using PersonalPortal.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IContentCategoryService, ContentCategoryService>();
builder.Services.AddScoped<IContentIdeaCategoryMediumService, ContentIdeaCategoryMediumService>();
builder.Services.AddScoped<IContentIdeaService, ContentIdeaService>();
builder.Services.AddScoped<IContentMediumService, ContentMediumService>();

builder.Services.AddScoped<IPlanService, PlanService>();
builder.Services.AddScoped<IStepService, StepService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IProjectTypeService, ProjectTypeService>();
builder.Services.AddScoped<IProjectCategoryService, ProjectCategoryService>();
builder.Services.AddScoped<IProjectCategoryTypeService, ProjectCategoryTypeService>();

builder.Services.AddScoped<IStaticResourceService, StaticResourceService>();
builder.Services.AddScoped<IStaticResourceTypeService, StaticResourceTypeService>();
builder.Services.AddScoped<IPlatformService, PlatformService>();
builder.Services.AddScoped<IResourceService, ResourceService>();
builder.Services.AddScoped<IResourceTypeService, ResourceTypeService>();
builder.Services.AddScoped<IResourceCategoryService, ResourceCategoryService>();
builder.Services.AddScoped<IResourceCategoryTypeService, ResourceCategoryTypeService>();

builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<IJobBulletPointService, JobBulletPointService>();
builder.Services.AddScoped<IContactInfoService, ContactInfoService>();
builder.Services.AddScoped<IContactInfoTypeService, ContactInfoTypeService>();
builder.Services.AddScoped<IEducationInfoService, EducationInfoService>();
builder.Services.AddScoped<IInterestService, InterestService>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<IResumeService, ResumeService>();
builder.Services.AddScoped<IResumeJobService, ResumeJobService>();
builder.Services.AddScoped<IResumeInterestService, ResumeInterestService>();
builder.Services.AddScoped<IResumeEducationInfoService, ResumeEducationInfoService>();
builder.Services.AddScoped<IResumeContactInfoService, ResumeContactInfoService>();
builder.Services.AddScoped<IResumeSkillService, ResumeSkillService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
