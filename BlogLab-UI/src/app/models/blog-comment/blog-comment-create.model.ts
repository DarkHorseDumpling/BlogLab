export class BlogCommentCreate {

    constructor(
        public blogCommentId: number,
        public content: string,
        public blogId: number,
        public parentBlogCommentId?: number
    ){}

} 