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
### Requirement 1: Search movies & tv shows with preferred criteria
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
As a user interested in watching movies and tv shows of my choice, I would be interested in their details like its plot, cast, ratings, director.

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
Ratings: (a number)

1.2 \
**Given** a data source of movies & tv shows is available \
**When** I search for any random value such as "GTFAGF98" \
**Then** I should receive zero results (empty list)

### Requirement 3: Filter Movies based on Release Year & Country
**Scenario** \
As a user interested in watching movies and tv shows of my choice, I would like to filter the movies and tv shows based on release year and country.

**Dependencies** \
Movies & tv shows search data available & accessible

**Examples** \
1.1 \
**Given** a data source of movies & tv shows is available \
**When** I filter the movie for year "2021" \
**Then** I should receive the list of movies and tv shows with the following attributes \
Movie or TV show name \
Release Year: (a number) \
Total number of movies: (a number)

**Examples** \
1.2 \
**Given** a data source of movies & tv shows is available \
**When** I filter the movie for country "India" \
**Then** I should receive the list movies and tv shows with the following attributes \
Movie or TV show name \
Country \ 
Total number of movies: (a number)

### Requirement 4: Display public reviews for a specific movie and tv shows
**Scenario** \
As a user interested in watching movies and tv shows of my choice, I would like to check the public reviews to decide on watching them.

**Dependencies** \
Movies & tv shows search data available & accessible

**Examples** \
1.1 \
**Given** a data source of movies & tv shows is available \
**When** I search for "Avengers" \
**Then** I should receive reviews with the following attributes \
Total number of reviews: (a number) \
Name of a user \
Ratings: (a number)

### Requirement 5: Display Top movies and tv shows list
**Scenario** \
As a user interested in knowing current top trending movies, web series or TV shows. \
I want to be able to fetch the list of current top 250 movies, web series or TV shows with their respective details.

**Dependencies** \
Movies & tv shows search data available & accessible

**Examples** \
1.1 \
**Given** a data source of movies & tv shows is available \
**When** I click on “Top 250 Movies” CTA in top navigation bar \
**Then** I should receive list of 250 movies with the following attributes (sample one movie attributes are shown below) \
      "Rank": "1", \
      "Title": "The Shawshank Redemption", \
      "Full Title": "The Shawshank Redemption (1994)", \
      "Year": "1994", \
      "Image": "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_Ratio0.6716_AL_.jpg", \
      "Crew": "Frank Darabont (dir.), Tim Robbins, Morgan Freeman", \
      "IMDb Rating": "9.2",
      
1.2 \
**Given** a data source of movies & tv shows is available \
**When** I click on “Top 250 TV shows” CTA in top navigation bar \
**Then** I should receive list of TV shows with the following attributes (sample one TV show attributes are shown below) \
      “Rank ": "1", \
      "Title": "Planet Earth II", \
      "Full Title": "Planet Earth II (2016)", \
      "Year": "2016", \
      "Image": "https://m.media-amazon.com/images/M/MV5BMGZmYmQ5NGQtNWQ1MC00NWZlLTg0MjYtYjJjMzQ5ODgxYzRkXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_Ratio0.7015_AL_.jpg", \
      "Crew": "David Attenborough, Gordon Buchanan", \
      "IMDb Rating": "9.4"

### Requirement 6: Get list of current running movies in theatre
**Scenario** \
As a user interested in knowing current in theatres movies.\
I want to be able to fetch the list of current in theatres movies with their respective details. \

**Dependencies** \
Movies & tv shows search data available & accessible

**Examples** \
1.1 \
**Given** a data source of movies & tv shows is available \
**When** I click on “Now Showing” CTA in top navigation bar \
**Then** I should receive list of movies which are currently running in theatres with the following attributes (sample one movie attributes are shown below) \
      "Title": "Black Adam", \
      "Full Title": "Black Adam (2022)", \
      "Year": "2022", \
      "Release Date": "21 Oct 2022", \
      "Image": "https://m.media-amazon.com/images/M/MV5BYzZkOGUwMzMtMTgyNS00YjFlLTg5NzYtZTE3Y2E5YTA5NWIyXkEyXkFqcGdeQXVyMjkwOTAyMDU@._V1_Ratio0.6699_AL_.jpg", \
      "Run Time in Minutes": "124", \
      "Plot": "Nearly 5,000 years after he was bestowed with the almighty powers of the Egyptian gods-and imprisoned just as quickly-Black Adam is freed from his earthly tomb, ready to unleash his unique form of justice on the modern world." \
      "Directors": "Jaume Collet-Serra", \
      "Stars": "Dwayne Johnson, Aldis Hodge, Pierce Brosnan, Noah Centineo" \
      
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
