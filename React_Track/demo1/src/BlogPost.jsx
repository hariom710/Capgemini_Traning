

export default function BlogPost({ title, author, content }) {
    return (
        <div className="blog-post">
            <h2>{title}</h2>
            <p><em>by {author}</em></p>
            <div>{content}</div>
        </div>
    );
}