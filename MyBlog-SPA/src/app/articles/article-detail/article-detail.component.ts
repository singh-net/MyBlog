import { AlertifyService } from './../../_services/alertify.service';
import { BlogPostService } from './../../_services/blogPost.service';
import { Blogpost } from './../../_models/blogpost';
import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-article-detail',
  templateUrl: './article-detail.component.html',
  styleUrls: ['./article-detail.component.css']
})
export class ArticleDetailComponent implements OnInit {
  @Input() article: Blogpost;
  constructor(private blogPostService: BlogPostService, private alertify: AlertifyService, private router: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadArticle();
  }

  loadArticle() {
    this.blogPostService.getBlogPost(+this.router.snapshot.params['id']).subscribe((article: Blogpost) => {
      this.article = article;
    }, error => {
      this.alertify.error(error);
    });
    
  }

}
