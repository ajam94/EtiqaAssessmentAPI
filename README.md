# EtiqaAssessment
<br />
Hi everyone, I'm Ahmad Muazzam Mustapha.<br />
This is my project for developing API for Etiqa Assessment.<br />
<br />
In this project, I have created an API for freelancers to be used by CDN Company (fictional company).
<br /><br />
There a several API that i developed:-<br />
1) @GET - to get list of all freelancers & by ID<br />
2) @POST - to create new freelancer in the record<br />
3) @PUT - to update the freelancer's information<br />
4) @DELETE - to delete freelancer's record from the record<br />
<br />
<br />
<br />
Attributes for freelancers:<br />
1) username<br />
2) mail<br />
3) phone number<br />
4) skillsets<br />
5) hobby<br />
<br /><br />
<br />
<br />
Software used:<br />
1. Ms Visual Studio 2022<br />
2. SQL Server Management Studio 19<br />
<br />
Template used: ASP.NET Core Web API<br />
<br />
Framework used: .Net 6<br />
<br />
API platform for testing API: Swagger (build in with the project)<br />
<br />
Packages used:<br />
1.	Microsoft.EntityFrameworkCore<br />
2.	Microsoft.EntityFrameworkCore.Tools<br />
3.	Microsoft.EntityFrameworkCore.SqlServer<br />
<br />
<br />
<br />
<br />
_Program.cs file_

1- To add services like Database, Entity Framework & more into the project

![image](https://github.com/ajam94/EtiqaAssessmentAPI/assets/29118844/ad154afe-5cf0-41f0-b0e6-66acae98c0ac)

2- To configure the HTTP request pipeline

![image](https://github.com/ajam94/EtiqaAssessmentAPI/assets/29118844/0f1bef99-51c2-4ca1-bc97-af58f98d393c)


_appsettings.json file_

- set the Connection String to connect with the database
- 
![image](https://github.com/ajam94/EtiqaAssessmentAPI/assets/29118844/cb5cf32e-d155-4f36-bab1-30e2f3c4b400)




_Models file_

1- Freelancers.cs
    - to declare all the attributes of the freelancers. 

 ![image](https://github.com/ajam94/EtiqaAssessmentAPI/assets/29118844/e074c37e-8375-41e6-9220-a024caf2cf43)


2- FreelancersContext.cs
    - to declare the Database of the freelancers table by using EntityFramework.

![image](https://github.com/ajam94/EtiqaAssessmentAPI/assets/29118844/4eb10c53-6ee5-471b-9c8a-9e3d266f5041)



_Controller file_

- FreelancersController.cs
    - to add all the API's for the freelancers table:
      1. (GET)- /api/GetAllFreelancers - get a list of all the freelancers
      2. (GET)- /api/GetFreelancerbyID/{id} - get list of a freelancer by ID
      3. (POST)- /api/CreateNewFreelancer - create new freelancer
      4. (PUT)- /api/UpdateFreelancerbyID/{id} - update freelancer's information
      5. (DELETE)- /api/DeleteFreelancerbyID/{id} - delete freelancer's record

![image](https://github.com/ajam94/EtiqaAssessmentAPI/assets/29118844/dd5c85fe-7ad5-416e-941a-7da5517c37ca)




Run the project...

We can straight away test our API using swagger (Please refer image below).

![image](https://github.com/ajam94/EtiqaAssessmentAPI/assets/29118844/b4ccbb43-d201-49ed-928e-198e32da8ae5)



<br />
<br />
<br />
<br />
<br />
<br />
Regards and Thank You.<br />
Ahmad Muazzam Mustapha<br />
.Net Developer
