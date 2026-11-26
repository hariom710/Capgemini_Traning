import BlogPost from "./BlogPost";

export default function BlogList({ posts }) {
    return posts.map((post, index) =>(
        <BlogPost key={index} title={post.title} author={post.author} content={post.content} />
    ));
}
