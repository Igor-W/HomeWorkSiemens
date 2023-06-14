import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { lastValueFrom } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(public http: HttpClient) { }

  getTasks(){
    return lastValueFrom(
      this.http.get('https://localhost:7164/tasks')
    );
  }
  getSteps(parentId: number){
    return lastValueFrom(
       this.http.post(`https://localhost:7164/tasks`,parentId)
    );
  }
}
