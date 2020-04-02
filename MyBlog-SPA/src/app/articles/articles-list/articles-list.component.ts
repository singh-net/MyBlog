import { Blogpost } from './../../_models/blogpost';
import { AlertifyService } from './../../_services/alertify.service';
import { BlogPostService } from './../../_services/blogPost.service';
import { Component, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-articles-list',
  templateUrl: './articles-list.component.html',
  styleUrls: ['./articles-list.component.css']
})
export class ArticlesListComponent implements OnInit {

  articles: Blogpost[];

  constructor(private blogPostService: BlogPostService, private alertify: AlertifyService, private sanitizer: DomSanitizer) { }

  ngOnInit(): void {
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
