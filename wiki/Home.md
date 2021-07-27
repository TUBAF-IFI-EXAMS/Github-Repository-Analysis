# GitHub project analysis

## Einleitung

Dieses Packet analysiert ein Github Repository. Als Eingabe akzeptiert es einen Repository Namen. Dann erhält es die grundlegenden Informationen des Projekts wie:
+ Repository full name
+ Repository  creation date
+ Repository  commits count
+ Repository  Pullrequeast count
+ Repository  Open Pullrequeast Count
+ Repository  Closed Pullrequeast Count
+ Repository  Issues Count
+ Repository  Open Issues Count
+ Repository  Closed Issues Count
+ Repository  folks count
+ Repository  Contributors count
+ Repository  HTML URL
+ Repository  Stars Count
+ Repository  Branchs Count
+ Repository  Branchs Name
+ Repository  Size
+ Repository  Id 
+ Repository Watchers Count

###   Vorgehen

Der Benutzer gibt den vollständigen Namen des Repositorys in der Kommandozeile als Eingabe für das Programm ein. Die Repository-Daten werden zunächst in einer Csv-Datei gespeichert bzw. geschrieben. Dann werden sie aus der Csv-Datei in das DataFrame-Objekt konvertiert bzw. in Tabellenformat gespeichert. Am Ende werden sie vom DataFrame ein Grafikdiagramm konvertiert und als Bild im aktuellen Arbeitsverzeichnis gespeichert.

### Vorgesehene Bibliothek

Für den Zugriff auf die Github-API : RestSharp  ( https://restsharp.dev/ )

zum Lesen/Schreiben von Csv in oder aus Datei : CsvHelper ( https://joshclose.github.io/CsvHelper/ )

zum Erstellen und Bearbeiten des DataFrame : Microsoft.Data.Analysis 0.4.0 ( https://github.com/dotnet/corefxlab )




### Beispiel

<!--more-->
|RepoFullName|RepoId|RepoSize|RepoBranchsCount|RepoCreationDate|RepoCommitsCount|RepoOpenPullRequeastCount|RepoClosedPullRequeastCount|RepoOpenIssuesCount|RepoClosedIssuesCount|RepoFolksCount|RepoContrubutorsCount |RepoUrl|RepoStarsCount|
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |--------|----|----|-------|---|---|
|   |   |   |   |   |   |   |   |   |   | |  |
|   |   |   |   |   |   |   |   |   |   | |  |
|   |   |   |   |   |   |   |   |   |   | |  |

### UML Diagramm
![First UML Diagramm](https://www.planttext.com/api/plantuml/img/dLLTIyCm57tFhxYFEkaVc6Ee4zt0Zp4H7qH6R2zRC4jcSYles7ytMLVMPebJNqgRSt9oppc1iZDBt52va8pbabiBruBcvUlvU3H4kKIpOd02AqSYaQyDya8h-GbRra0AL0Ih6T8fW7NFTHScQ6aBi9DGxkYurykr8ctwVROJXf4YmQNumchdqN4NFhGe65lNSqrmgIyvyLjTe6IRiKR5zkZjoKAHNuQhKihf7LzW4zuWGrh8wQEHq4IW-q16g9bdL6ymS4u9Y-avfOdSpFWN6ZlGfGfemdjtf2jjtcoUnfyuvVEen8RXl0VcnqRdQArsjVXiaMh01NOZBFNyT-6--pwvlLtGoR8WoA0VoBAiitzSSuuBmrK-3wge5d_AegPiYh4jYWjJ-5oVNzfrxqwA-gxWflDWD1y2C9QGghC8_IGJYMZKquxTZPlWU-ckVZkO1f3Evdw9wbV4WTGMY_zeGYhmY6YIsoedi1njgC5frXHBgz5LIjaN5WqwsLXAgVOnijPXxSQgjL_bMr4FrNM8jLCwMD81MgkVdRTeDHNyXrOYUhwGCC9a5v7zZ9sXAjo_vni0)


![Second UML Diagramm](https://www.planttext.com/api/plantuml/img/fPJHQeCm58RlprCSs8rIV04dqewoTR11wRe7IFNCocAo9P7HETzzKH6rDMMmE-Fv_-_yEOd2KXkcJ5bmW8GphV4XDvloiAEF5HECdxv9GGK5ouNdGzrhDg-QrAeqHn8cJvZ9fQW0RYeBi-jQ4Kkbu2TiQ5bvQDHOPMHkwp345wDoaI4WB6P9dXz5YHH6gZYUav1dv3k97kI7JPTZryL6X7udTWzopGoxLwoW2d21VRvfgKk6gDjyEBoFeZLHoid6iEPLcku7avVQfn2VScsYVUoxR3NWA4pECgie_fzbhTZNcDYcUMk58zFWiVcQB1UZsIgPaDPIsTEpaoRJ5pm_RBVMh1js3EUJlLDC94Sdf2kFCOFXMQR46o82JA7RalCTVPQaZPCyqepnPrPtZqUjhSY9xyf_8rz-AnW4Fp7ENkjvTJ0zVuSecDoVwwBnngxrTCrwtkCQtTKiCtUaEuqbYTJ-Stu1)

### Beispiel für die grafische Darstellung
![Diagramm](https://user-images.githubusercontent.com/66778493/124915997-756ba280-dff2-11eb-97c5-c6a2523085b8.png)



