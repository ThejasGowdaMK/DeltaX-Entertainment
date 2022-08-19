DeltaX - Backend Assignment(Product Engineer .net)

Problem Statement.


          To design a database and build a REST api for a movie application like IMDB.
                    
Technology used.


          Asp.net core webapi architecture and entityframework to connect with Local SQL database.
          
          
Entry Point.


          Project has only one controller that is “MovieController”  it has all the 3 REST api.
          
          
Database Model.




Created 4 table under Entertainment database (named it because in future other source entertainment arises other that movie) 
a. Movie

b. Producer

c. Actor

d. Table connecting Movie and Actor.



REST api.


1. HttpGet – “api/Movie/Movies”

   It will return all the movies information that is required.
   Sample Output-
   
   
   
    [
    
    
    {
        "Release_Date": "2020-04-08T00:00:00",
        "Producer": "Vijay",
        "Actors": [
            "Yash",
            "Srinidhi"
        ],
        "Movie_Name": "KGF"
    },
    
    
    {
        "Release_Date": "2020-12-07T00:00:00",
        "Producer": "Kishore",
        "Actors": [
            "Punith",
            "Priya Anand",
            "Doli"
        ],
        "Movie_Name": "Ugram"
    },
    
    
    {
        "Release_Date": "2019-12-06T00:00:00",
        "Producer": "Kishore",
        "Actors": [
            "Punith",
            "Radhika"
        ],
        "Movie_Name": "Hudugaru"
    },
    
    
    {
        "Release_Date": "2019-12-06T00:00:00",
        "Producer": "Kishore",
        "Actors": [
            "Punith",
            "Priya Anand",
            "Doli"
        ],
        "Movie_Name": "James"
    },
    
    
    
    {
        "Release_Date": "2012-12-06T00:00:00",
        "Producer": "Kishore",
        "Actors": [
            "Punith",
            "Priya Anand",
            "Doli"
        ],
        "Movie_Name": "KGF-2"
    }
]




2. HttpPost - “api/Movie/Movies”




   It will insert movie in database, if not already present and returns true. If it is present, it will throw an exception.

 Sample Input 1:
 
 
   Body - 
   
      
      {
    "Movie_Name":"Yuvaratna",
    "Release_Date":"12/07/2020",
    "Producer":"Kishore",
    "Actors":["Punith","Doli"]
       }
       
       
Output – true.

Sample Input 2:


Body - 


      {
        "Release_Date": "2012-12-06T00:00:00",
        "Producer": "Kishore",
        "Actors": [
            "Punith",
            "Priya Anand",
            "Doli"
        ],
        "Movie_Name": "KGF-2"
      }
      
      

    Output - "Message": "An error has occurred.",
             "ExceptionMessage": "Movie is already present in Database",






3. HttpPut – “api/Movie/editMovie” 




   It will edit movie in database if present and returns true. If it is not present it will throw an exception.
   
   

Sample Input 1:

Body -   


           {
    "Movie_Name":"Yuvaratna",
    "Release_Date":"12/07/2020",
    "Producer":"Kishore",
    "Actors":["Punith","Priya Anand","Doli"]
           }
           

Output – true


Sample Input 2:

Body – 


      {
    "Movie_Name":"XYZ",
    "Release_Date":"12/07/2020",
    "Producer":"Kishore",
    "Actors":["Punith","Priya Anand","Doli"]
       }
       
       

Output - "Message": "An error has occurred.",
         "ExceptionMessage": "Movie is not present in database please verify",
