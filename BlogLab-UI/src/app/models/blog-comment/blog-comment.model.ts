export class BlogComment {

    constructor(
        public blogCommentId: number,
        public content: string,
        public blogId: number,
        public username: string,
        public applicationUserId: number,
        public publishDate: Date,
        public updateDate: Date,
        public parentBlogCommentId?: number
    ){}

} 