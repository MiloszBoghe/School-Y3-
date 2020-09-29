import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Todo } from './../models/todo.model';

@Injectable()
export class TodoService {
    apiurl: string = 'api/todo';
    constructor(private http: HttpClient) { }

    getTodos(searchText?: string) {
        if (!searchText)
            return this.http.get<Todo[]>(this.apiurl);
        else {
            searchText = searchText.trim();
            const options = { params: new HttpParams().set('name', searchText) };

            return this.http.get<Todo[]>(this.apiurl, options);
        }
    }

    getTodo(id: number) {
        return this.http.get<Todo>(`${this.apiurl}/${id}`);
    }

    addTodo(item: Object) {
        return this.http.post(this.apiurl, item);
    }

    removeTodo(item: Todo) {
        return this.http.delete(`${this.apiurl}/${item.id}`);
    }

    updateTodo(item: Todo) {
        return this.http.put(this.apiurl, item);
    }


}