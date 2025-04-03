# Bee Hive Server

This project is an ASP .net C# based web application/web api that accepts requests from my Arduino modules and collects them into my MongoDB database that I can use later for data analytics. 

[Video](https://youtu.be/eRlTWCA2U4I)

>[!NODE]
>This video is literally recorded in 480p on my laptop. I don't know why but prepare yourself for the quality.
---
# Dev Environment / Challenges / Story!

Again, this project was created in the ASP .net core, and I used MongoDB as my database of choice. I really didn't have a particularly great reason for using either of these frameworks/databases; I just wanted to try to use something I wouldn't normally use. In hindsight, I found C# is great for coding, but the Microsoft tools can be boring and lazy to use at times. and Mongo db worked like a charm, although I do think that the service is overkill and potentially wasteful for the type of work I am giving it. I would also like to take the time to mention that this project was built with the idea of having everything be local. I prefer to use my own servers, so there is the option to use the docker container that I will be using. I would warn others about trying to get .NET code running on linux without docker; trust me it is a pain.

In the future, I would really like to keep working on this, especially as I can continue working on this in production. I am actually going to be rolling this out on some of the hives during the spring and collecting some extra data. Had I more time, interest, and design inspiration, I would have created a more interesting interface, but seeing as MongoDB has tools to handle data aggregation and visuals, I found that simply collecting the information would suffice for the time being. Als, I recently got re-employed, and some more information about my graduate application are starting to become more important; they have been taking time away from my less immediately important projects.

>[!important]
>If you are planning on using this code in any way, please change the application settings json file. I have excluded my information, and you need to exchange it with your MongoDB link, etc.

---

---
# Future Ideas

 - More Audio Formats
 - Waveform Visualization
