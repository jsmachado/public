import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

// SignalR
import { SignalRModule, SignalRConfiguration } from 'ng2-signalr';

import { environment } from '../environments/environment';

// v2.0.0
export function createConfig(): SignalRConfiguration {
  const c = new SignalRConfiguration();
  c.hubName = environment.hubName;
  c.withCredentials = true;
  c.url = environment.signalrUrlBase;
  c.logging = true;
  return c;
}

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    SignalRModule.forRoot(createConfig)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
