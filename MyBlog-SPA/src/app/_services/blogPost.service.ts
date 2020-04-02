import { Blogpost } from './../_models/blogpost';
import { Observable } from 'rxjs';
import { environment } from './../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BlogPostService {
  baseUrl = environment.apiUrl;

constructor(private http: HttpClient) { }

getBlogPosts(): Observable<Blogpost[]> {
  return this.http.get<Blogpost[]>(this.baseUrl + 'blogposts');
}
getBlogPost(id: number): Observable<Blogpost> {
  return this.http.get<Blogpost>(this.baseUrl + 'blogposts/' + id);
}

}

