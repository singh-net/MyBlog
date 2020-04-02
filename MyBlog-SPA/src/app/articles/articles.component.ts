import { Blogpost } from './../_models/blogpost';
import { AlertifyService } from './../_services/alertify.service';
import { BlogPostService } from './../_services/blogPost.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.css']
})
export class ArticlesComponent implements OnInit {

  articles: Blogpost[];

  constructor(private blogPostService: BlogPostService, private alertify: AlertifyService ) { }

  ngOnInit() {
    this.loadArticles();
  }

  loadArticles() {
  this.blogPostService.getBlogPosts().subscribe((articles: Blogpost[]) => {
    this.articles = articles;
  }, error => {
    this.alertify.error(error);
  });
  }

}
