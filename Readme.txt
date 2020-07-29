Setup:

1. Login the teams client with credentials.
2. Clone this repo.
3. Open supported files folder.
    a. Install ngrok
      i. Open command propomt in admin mode.
      ii. cp n paste the cmd: ngrok.exe start -all -config <yaml file path - placed under supported files folder>
      iii. ngrok endpoints should mapp to the visual studio project <loclahost:12345> in host file.
4. Schedule a meeting in the teams client.
5. Copy the meeting invite and pass as json request on the ngrok endpoint.
Sample Request:
{
    "JoinURL": "https://teams.microsoft.com/l/meetup-join/19%3ameeting_Y2FkMDk1MGMtZTcyNi00MDY5LTk5OWUtYTFlZTA0ZGI1NTQ0%40thread.v2/0?context="
}
6. Other way, open the tryout bot and call.
