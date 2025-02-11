import { Routes } from '@angular/router';
import { TodoListComponent } from './pages/todo-list.component';

export const routes: Routes = [
  {
    //navigate to /todo-list then it will show the todolist component
    path: 'todo-list',
    component: TodoListComponent,
  },
];
