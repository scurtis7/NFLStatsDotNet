import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {AboutComponent} from './about/about.component';
import {SigninComponent} from './signin/signin.component';
import {TeamsComponent} from './teams/teams.component';
import {PlayersComponent} from './players/players.component';
import {RankingsComponent} from './rankings/rankings.component';

const routes: Routes = [
  {path: 'about', component: AboutComponent},
  {path: 'signin', component: SigninComponent},
  {path: 'teams', component: TeamsComponent},
  {path: 'players', component: PlayersComponent},
  {path: 'rankings', component: RankingsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
