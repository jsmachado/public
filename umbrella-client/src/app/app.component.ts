import { Component, OnInit } from '@angular/core';
import { Observable } from "rxjs/Rx";
import { SignalR } from 'ng2-signalr';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  ticker: string;

  constructor(private _signalR: SignalR) { }

  public ngOnInit(): void {
    let clientReceiveMessage$: Observable<string> = Observable
      .fromPromise(this._signalR.connect())
      .flatMap(conn => conn.listenFor("clientReceiveMessage"));

    clientReceiveMessage$.subscribe(message => {
      this.ticker = message;
    });
  }
}
