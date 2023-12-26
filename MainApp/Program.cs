using Domain.Models;
using Infrastructure.Services;

var st1 = new Posts();
st1.Id = 1;
st1.FirstName = "ghhh";
st1.LastName ="udcbai;";
st1.Adress = "Sino";
var st2 = new Posts();
st2.Id = 2;
st2.FirstName = "ghhh";
st2.LastName ="udcbai;";
st2.Adress = "Sino";


var ser1 = new PostsServices();
ser1.AddPosts(st1);
ser1.AddPosts(st2);

foreach (var item in ser1.GetPosts())
{
    Console.WriteLine(item.FirstName);
    Console.WriteLine(item.LastName);
    Console.WriteLine(item.Adress);
    Console.WriteLine("-----------------------");
}
var st17 = new Posts();
st17.Id = 5;
st17.FirstName = "Umed";
st17.LastName = "Umedov";
st17.Adress = "Rudaki";foreach (var item in ser1.GetPosts())
{
    Console.WriteLine(item.FirstName);
    Console.WriteLine(item.LastName);
    Console.WriteLine(item.Adress);
    Console.WriteLine("-----------------------");
}
ser1.UpdatePosts(st17);
foreach (var item in ser1.GetPosts())
{
    Console.WriteLine(item.FirstName);
    Console.WriteLine(item.LastName);
    Console.WriteLine(item.Adress);
    Console.WriteLine("-----------------------");
}
ser1.DeleteStudent(15);



var te1 = new Teachers();
te1.Id = 1;
te1.FirstName = "ghhh";
te1.LastName ="udcbai;";
te1.Position= "Teacher";
te1.ExpiarenceAmount = 10;
var te2 = new Teachers();
te2.Id = 2;
te2.FirstName = "ghhh";
te2.LastName ="udcbai;";
te2.Position = "Teacher";
te2.ExpiarenceAmount = 10;

var tech1 = new TeachersServices();
tech1.AddTeachers(te1);
tech1.AddTeachers(te2);

foreach (var item in tech1.GetTeachers())
{
    Console.WriteLine(item.FirstName);
    Console.WriteLine(item.LastName);
    Console.WriteLine(item.Position);
    Console.WriteLine("-----------------------");
}
var te17 = new Teachers();
te17.Id = 5;
te17.FirstName = "Umed";
te17.LastName = "Umedov";
te17.Position = "Rudaki";
te17.ExpiarenceAmount = 10;
foreach (var item in tech1.GetTeachers())
{
    Console.WriteLine(item.FirstName);
    Console.WriteLine(item.LastName);
    Console.WriteLine(item.Position);
    Console.WriteLine(item.ExpiarenceAmount);
    Console.WriteLine("-----------------------");
}
tech1.UpdateTeachers(te17);
foreach (var item in tech1.GetTeachers())
{
    Console.WriteLine(item.FirstName);
    Console.WriteLine(item.LastName);
    Console.WriteLine(item.Position);
    Console.WriteLine(item.ExpiarenceAmount);
    Console.WriteLine("-----------------------");
}
tech1.DeleteTeachers(15);


var cs1 = new Courses();
cs1.Id = 1;
cs1.Title = "ghhh";
cs1.Description="udcbai;";
cs1.Fee = 15;
var cs2 = new Courses();
cs2.Id = 2;
cs2.HasDiscount = true;
cs2.Description="udcbai;";
cs2.Fee = 15;


var csr1 = new CoursesServices();
csr1.AddCourses(cs1);
csr1.AddCourses(cs2);

foreach (var item in csr1.GetCourses())
{
    Console.WriteLine(item.Title);
    Console.WriteLine(item.HasDiscount);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.Fee);
    Console.WriteLine("-----------------------");
}
var cs17 = new Courses();
cs17.Id = 5;
cs17.HasDiscount = false;
cs17.Description= "Umedov";
cs17.Fee = 10;
foreach (var item in csr1.GetCourses())
{
    Console.WriteLine(item.Title);
    Console.WriteLine(item.HasDiscount);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.Fee);
    Console.WriteLine("-----------------------");
}
csr1.UpdateCourses(cs17);
foreach (var item in csr1.GetCourses())
{
    Console.WriteLine(item.Title);
    Console.WriteLine(item.HasDiscount);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.Fee);
    Console.WriteLine("-----------------------");
}
csr1.DeleteCourses(15);

var ps1 = new Posts();
ps1.Id = 1;
ps1.Title = "ghhh";
ps1.Description ="udcbai;";
ps1.VoteAmount = 151;
var ps2 = new Posts();
ps2.Id = 2;
ps2.Title = "ghhh";
ps2.Description ="udcbai;";
ps2.VoteAmount = 159;


var pss1 = new PostsServices();
pss1.AddPosts(ps1);
pss1.AddPosts(ps2);

foreach (var item in pss1.GetPosts())
{
    Console.WriteLine(item.Title);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.VoteAmount);
    Console.WriteLine("-----------------------");
}
var ps17 = new Posts();
ps17.Id = 5;
ps17.Title = "Umed";
ps17.Description = "Umedov";
ps17.VoteAmount = 136;
foreach (var item in pss1.GetPosts())
{
    Console.WriteLine(item.Title);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.VoteAmount);
    Console.WriteLine("-----------------------");
}
pss1.UpdatePosts(st17);
foreach (var item in pss1.GetPosts())
{
    Console.WriteLine(item.Title);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.VoteAmount);
    Console.WriteLine("-----------------------");
}
pss1.DeletePosts(2);

