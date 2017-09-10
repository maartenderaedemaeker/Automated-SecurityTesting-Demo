import { Component, Inject } from '@angular/core';
import { Http } from "@angular/http";
import { Observable } from "rxjs/Observable";
import { IntervalObservable } from 'rxjs/observable/IntervalObservable';
import 'rxjs/Rx';

@Component({
    selector: 'counter',
    templateUrl: './counter.component.html'
})

export class CounterComponent {

    private dumps : object[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        console.log(baseUrl);
        
        IntervalObservable.create(5000).flatMap(() => {
            return http.get(baseUrl + 'api/Dump');
        })
        .map((result) => {
            return result.json();
        })
        .subscribe(result => {
            this.dumps = result;
        }, error => console.error(error));
    }
}