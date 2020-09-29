import { Component, OnInit } from '@angular/core';
import { TodoService } from './shared/services/todo.service';
import { Observable } from 'rxjs';
import { Todo } from './shared/models/todo.model';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  todoList$: Observable<Todo[]>;
  editing: boolean = false;
  editingItem: Todo;

  constructor(private ts: TodoService) { }

  ngOnInit() {
    this.fetchList();
  }

  fetchList(){
    this.todoList$ = this.ts.getTodos();
  }

  add(form: any){
    this.ts.addTodo({name: form.value.name}).subscribe(_ => {
      this.fetchList()
      form.reset();
    });
  }

  delete(item: Todo){
    this.ts.removeTodo(item).subscribe(_ => this.fetchList());
  }

  edit(item : Todo){
    this.editing = true;
    this.editingItem = item;
  }

  saveEdit(){
    this.ts.updateTodo(this.editingItem).subscribe(_ => {
      this.editing = false;
      this.editingItem = undefined;
    });
   
  }

  todoClick(item: Todo){
    this.ts.getTodo(item.id).subscribe(data => alert(data.name));
  }

  search(searchTerm: string){
    this.todoList$ = this.ts.getTodos(searchTerm);
  }

}
