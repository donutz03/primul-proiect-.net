var builder = WebApplciation.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts;
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();


//cshtml
@page

<h1>Hello world</h1>
<h2>The time on the srv is @DateTime.Now</h2>
//razor pages file name must hjave a .cshtml suffix

//cshtml
@page
@using RazorPagesIntro.Pages
@model Index2Model

<h2>Separate page model</h2>
<p>
    @Model.Message
</p>

//Pages/Index2.cshtml.cs page model:
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace RazorPagesIntro.Pages
{
    public class Index2Model : PageMode;
    {
        public string Message {get; private set;} = "PageModel in C#";
    

         public void OnGet() 
            {
                Message += $" Server time is { DateTime.Now }";
            }
    }
}

//simple form
using Microsoft.EntityFrameworkCore;
using RazorPagesContacts.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<CustomerDbContext>(options =>
    options.UseInMemoryDatabase("name"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.Run();

//the data model:

using System.ComponentModel.DataAnnotations;

namespace RazorPagesContacts.Models
{
    public class CustomerDbContext
    {
        public int Id {
            get; set;
        }

        [Required, StringLength(10)]
        public string? Name {get; set;}
    }
}

// The db context:
using Microsoft.EntityFrameworkCore;

namespace RazorPagesContacts.Data 
{
    public class CustomerDbContext : DbContext
    {
        public Customer DbContext (DbContextOptions<CustomerDbCOntext> options)
            :base(options)
            {

            }

            public DbSet<RazorPagesCotnacts.Models.Customer> Customer => Set<RazorPagesContacts.Models.Customer>();
    }
}

//The Pages/Customers/Create.cshtml view file:
@page
@model RazorPagesContacts.Pages.Customers.CreateModel
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

<p>Enter a customer name:</p>

<form method="post">
    Name:
    <input asp-for="Customer!.Name" />
    <input type="submit" />
</form>

//The Pages/Customers/Create.cshtml.cs page models

public class CreateModel : PageModel {
    private readonly Data.CustomerDbContext _context;

    public CreateModel(Data.CustomerDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet() 
    {
        return Page();
    }

    [BindProperty]
    public Customer? Customer {get; set;}

    public async Task<IactionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (Customer != null) _context.Customer.Add(Customer);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}

[BindProperty]
public Customer? Customer {get; set;}

public async Task<IActionResult> OnPostAsync()
{
    if (!ModelState.IsValid)
    {
        return Page();
    }

    if (Customer != null) _context.Customer.Add(Customer);
    await _context.SaveChangesAsync();

    return RedirectToPage("./Index");
}

// the Pages/Customers/Create.cshtml file:

@page
@model RazorPagesContacts.Pages.Customers.CreateModel
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

<p>Enter a customer name:</p>

<form method="post">
    Name:
    <input asp-for="Customer!.Name" />
    <input type="submit" />
</form>

//The rendered HTML from Pages/Customers/Create.cshtml
<p>Enter a customer name:</p>

<form method="post">
    Name:
    <input type="text" data-val="true"
            data-val-length="The field Name must be a string with maximum length of 10."
            data-val-length-max="10" data-val-required="The Name field is required."
            id="Customer_Name" maxlength="10" name="Customer.Name" value="" />
    <input type="submit" />
    <input name="__RequestVerificationToken" type="hidden"
           value="<Antiforgery token here>" />
</form>

[BindProperty]
public Customer? Customer {get; set;}

public async Task<IActionResult> OnPostAsync()
{
    if (!ModelState.IsValid)
    {
        return Page();
    }

    if (Customer!= null) _context.Customer.Add(Customer);
    await _context.SaveChangesAsync();

    return RedirectToPage("./Index");
}


public class CreateModel : PageModel
{
    private readonly Data.CustomerDbCOntext _context
}

public class CreateModel : PageModel
{
    private readonly Data.CustomerDbCOntext _context;

    public CreateModeL(Data.CustomerDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page()
    ;
    }

    [BindProperty]
    public Customer? Customer {get;set;}

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page()
            ;
        }

        if (Customer != null) _context.Customer.Add(Customer);
        await _context.SaveChangesAsync();
        
        return RedirectToPage("./Index") ;   } 
}

// <input asp-for="Customer.Name">
[BindProperty(SupportsGet = true)]

@page
@model RazorPagesContacts.Pages.Customers.CreateModel
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

<p> Enter cust naem: </p>
<form method="post">
    Name:
    <input asp-for="Customer!.Name" />
    <input type="submit">
</form>