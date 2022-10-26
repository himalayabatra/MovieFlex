# MOVIEFLEX

---
## Introduction:

Looking for a next movie or show? You are in the right place - Movieflex, get all the information about the movies and tvshows with just one-click.
**MOVIEFLEX** enables you with following:

- Search movies/tv shows of different genre, cast, director
- Display the details of specific movie
- Filter movies based Release Year & Country
- Get public reviews for a specific movie/tv shows
- Top movies/tv shows list
- Get list of current running movies in theatre
---
## Logo:
![Logo](https://user-images.githubusercontent.com/77502128/197602797-e214cafb-158c-417b-883c-f596619f2614.png)
---
## Storyboard:
![Home Page](https://user-images.githubusercontent.com/77502128/197637639-5844fdfb-be6c-4e17-a0ba-c63b94f6be9b.png)
---

## Functional Requirements:
### Requirement 1**: Search movies & tv shows with preferred criteria
**Scenario** \
As a user interested in watching movies and tv shows of my choice, I want to search movies & tv shows based on different criteria.

**Dependencies** \
Movies & tv shows search data available & accessible

**Examples** \
1.1 \
**Given** a data source of movies & tv shows is available \
**When** I search for "Christopher Nolan" \
**Then** I should receive a list of all the movies and tv shows with following attributes \
Movie or TV show name \
Director name: \
Total number of movies: (a number)

1.2 \
**Given** a data source of movies & tv shows is available \
**When** I search for "Jim Carrey" \
**Then** I should receive a list of all the movies and tv shows with following attributes \
Movie or TV show name \
Actor or Actress name \
Total number of movies: (a number)

1.3 \
**Given** a data source of movies & tv shows is available \
**When** I search for "Comedy" \
**Then** I should receive a list of all the movies and tv shows with following attributes \
Movie or TV show name \
Genre type \
Total number of movies: (a number)

1.4 \
**Given** a data source of movies & tv shows is available \
**When** I search for any random value such as "7866HHHYHJ" \
**Then** I should receive zero results (empty list)

### Requirement 2: Display Details Of Certain Movies
**Scenario** \
As a user interested in watching movies and tv shows of my choice, I would be interested in their details like its plot, cast, reviews, director.

**Dependencies** \
Movies & tv shows search data available & accessible

**Examples** \
1.1 \
**Given** a data source of movies & tv shows is available \
**When** I search for "Batman" \
**Then** I should receive list of all movies with following attributes \
Title name \
Plot details \
Cast details \
Reviews: (a number)

1.2 \
**Given** a data source of movies & tv shows is available \
**When** I search for any random value such as "GTFAGF98" \
**Then** I should receive zero results (empty list)

---

## Data Source:
- [IMDB Movie Data API - Top 250 Movies](https://imdb-api.com/en/API/Top250Movies/k_thj97up3)
- [OMDB Movie Data API - Specific Movie Details](https://www.omdbapi.com/?apikey=c604051a&t=Batman)

**Credits:**
- [IMDB API](https://imdb-api.com/)
- [OMDB API](http://www.omdbapi.com/)
---

## Scrum Roles:
- Product Owner: Himalaya Batra
- Scrum Master: Krunal Dilip Shigavan
- Front-End Developer: Jaswanth Bathi 
- DevOps Architect: Arunkumar Dubey
- Integration Developer: Saurav Nandi

## Weekly Meeting:
Tuesday 1:10 PM on Zoom
[Meeting Link](https://us05web.zoom.us/j/86110908327?pwd=anlkTUU2VW9GS2hDa1FUNitvdWJRdz09)

Meeting ID: 861 1090 8327
Passcode: 4jJBAH
