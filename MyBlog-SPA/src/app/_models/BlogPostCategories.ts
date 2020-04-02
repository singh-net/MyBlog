export interface BlogPostCategories {
        blogPostId: number;
        categoryId: number;
        category: {
            id: number;
            name: string;
            status: string;
            parent: number;
            };
}
