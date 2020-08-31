import { Component, OnInit } from '@angular/core';
import {NflPlayer} from '../model/nfl-player';
import {NflstatsService} from '../service/nflstats.service';

@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  styleUrls: ['./players.component.css']
})
export class PlayersComponent implements OnInit {

  players: NflPlayer[];

  constructor(private nflStatsService: NflstatsService) { }

  ngOnInit() {
    this.nflStatsService.getPlayers()
      .subscribe(result => this.players = result.players);
  }

}
