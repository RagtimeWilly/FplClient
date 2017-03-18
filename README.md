# FplClient

![Build Status](https://ci.appveyor.com/api/projects/status/github/RagtimeWilly/FplClient?branch=master&svg=true) [![NuGet](https://img.shields.io/nuget/v/FplClient.svg)](https://www.nuget.org/packages/FplClient/)

.NET library which provides a simple interface for the official Fantasy Premier League API (https://fantasy.premierleague.com).

## Installing from NuGet

`PM> Install-Package FplClient`

## Clients

All clients need to be provided with a `Func<HttpClient>` upon construction, e.g, `() => new HttpClient();`

## Entries Client

You can access team data for a given gameweek by using the `FplEntryClient`.

```
var client = new FplEntryClient(() => new HttpClient());

var team = client
             .GetTeam(teamId: 12345, gameweek: 1)
             .Result;
```
This will return the [FplEventEntry](https://github.com/RagtimeWilly/FplClient/blob/master/src/FplClient/Data/FplEventEntry.cs) data.

The team id can be found the url of any gameweek points page: https://fantasy.premierleague.com/a/team/_**12345**_/event/1

## Entry History Client

You can access team histories (chips used, gameweek ranks, season ranks, etc) by using the `FplEntryHistoryClient`.

```
var client = new FplEntryHistoryClient(() => new HttpClient());

var team = client
             .GetTeam(teamId: 12345)
             .Result;
```
This will return the [FplEntryHistory](https://github.com/RagtimeWilly/FplClient/blob/master/src/FplClient/Data/FplEntryHistory.cs) data.

## Entry History Client

You can access league data by using the `FplLeagueClient`.

Different data formats are returned depending on whether the league types is _Classic_ or _Head to Head_.

The league id can be found the url of the league page: https://fantasy.premierleague.com/a/leagues/standings/_**313**_/classic

### Classic Leagues

```
var client = new FplLeagueClient(() => new HttpClient());

// First page
var classicLeagueData = client
             .GetClassicLeague(leagueId: 313)
             .Result;

// Include page number for subsequent pages
var classicLeagueData = client
             .GetClassicLeague(leagueId: 313, page: 2)
             .Result;
```
This will return the [FplClassicLeague](https://github.com/RagtimeWilly/FplClient/blob/master/src/FplClient/Data/FplClassicLeague.cs) data.

### Head to Head Leagues

```
var client = new FplLeagueClient(() => new HttpClient());

// First page
var h2hData = client
             .GetHeadToHeadLeague(leagueId: 12345)
             .Result;
```
This will return the [FplHeadToHeadLeague](https://github.com/RagtimeWilly/FplClient/blob/master/src/FplClient/Data/FplHeadToHeadLeague.cs) data.

### Players

You can access player data by using the `FplLeagueClient`.

### All players

```
var client = new FplPlayerClient(() => new HttpClient());

// First page
var players = client
             .GetAllPlayers()
             .Result;
```
This will return all the [FplPlayer](https://github.com/RagtimeWilly/FplClient/blob/master/src/FplClient/Data/FplPlayer.cs) data as an `IEnumerable<FplPlayer>`.


### Individual players

```
var client = new FplPlayerClient(() => new HttpClient());

// First page
var playerData = client
             .GetPlayer(playerId: 1)
             .Result;
```
This will return the [FplPlayerSummary](https://github.com/RagtimeWilly/FplClient/blob/master/src/FplClient/Data/FplPlayerSummary.cs) data.

## Getting help

If you have any problems or suggestions please create an [issue](https://github.com/RagtimeWilly/FplClient/issues) or a [pull request](https://github.com/RagtimeWilly/FplClient/pulls)