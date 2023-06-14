import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

import { TaskService } from './task.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent {
  createChildren: any;

  constructor( private _taskService: TaskService) {
    this.createChildren = (parent: any) => {
      const parentId = parent ? parent.itemData.id : '';

      if (parentId) return _taskService.getSteps(parentId);
      else return _taskService.getTasks();
    };
  }
}
