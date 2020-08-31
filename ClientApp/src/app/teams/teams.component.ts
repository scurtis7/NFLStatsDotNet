import { Component, OnInit } from '@angular/core';
import {NflTeam} from '../model/nfl-team';
import {NflstatsService} from '../service/nflstats.service';

@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html',
  styleUrls: ['./teams.component.css']
})
export class TeamsComponent implements OnInit {

  teams: NflTeam[];

  constructor(private nflStatsService: NflstatsService) {
  }

  ngOnInit() {
    this.nflStatsService.getTeams()
      .subscribe(result => this.teams = result.teams);
  }

}
