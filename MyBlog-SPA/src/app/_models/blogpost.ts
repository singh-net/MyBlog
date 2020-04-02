import { BlogPostCategories } from './BlogPostCategories';

export interface Blogpost {

    id: number;
    title: string;
    contents: string;
    dateCreated: Date;
    dateModified: Date;
    excerpt: string;
    status: string;
    categories: {
        id: number,
        name: string
    }
}
