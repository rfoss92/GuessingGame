# GuessingGame

This is a personal project to test my skills in C# and .NET. 

The user is prompeted to guess a number between 1 and 100 and is given a hint (higher or lower) until the guess it right.
To prevent the user from cheating with the developer console, the correct number is on the server and the only information the user
receives is the hint. SessionIds are used to maintain several users at once without conflicting the sessions.

I intend to implement a database and a load balancer so users can't hijack another user's session and to distribute the traffic
when scaling.
