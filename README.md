# oop
##Class Notes for MTH404E - Object Oriented Programming with C# 

data can be obtained from an external data source. assume that we have a JSON file like below. this JSON data can be pulled from a database like MongoDB, an API like REST / SOAP / gRPC <br/>
```
{
"id": "000000",
"title": "Inventory Tracking System",
"summary": "Stores Stock Information",
"level": 100
}
```
we could also define this information with concepts like XML, CVS, etc. <br/>
```
<homework>
  <id>000000</id>
  <title>Inventory Tracking System</title>
  <summary>Stores Stock Information</summary>
  <level>100</level>
</homework>
```

we can divide the memory into two parts: stack and heap.
* stack works with the last in first out principle. this part of the memory works fast. that's why keeping the variables called often is a good practice. this way, we create variables and dispose of them quickly. some of the variables in here like boolean, fixed numbers, and chars have defined structures so storing them in a stack increases performance. this <b>value types</b> stored in stack are generally created as <b>struct</b> data type.
* heap stores complex data structures and functions. since this component's properties are unknown when defined, storing them in a heap is a good practice. because they are not disposable due to their complex structure and should store longer. this <b>reference types</b> are generally created as <b> class </b> data type.

#terminal commands:
```
dotnet new console -n ProjectName // creates a new project
dotnet run // runs project
dotnet new sln // creates a solution file
```
we create solution files at c# projects. a solution is a grouping of one or more projects that work together to create an application.

