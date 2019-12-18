import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.scss']
})
export class AppComponent {
    title = 'in-touch';

    constructor(http: HttpClient) {
        http.get<string[]>('https://localhost:44360/api/ChatList').subscribe(result => {
          console.log(result);
        }, (error: any) => console.error(error));
      }
}
