import BlogList from "./BlogList";

const samplePosts = [
    { title: "First Post", author: "Alice", content: "This is the first blog post." },
    { title: "Second Post", author: "Bob", content: "This is the second blog post." },
    { title: "Third Post", author: "Charlie", content: "This is the third blog post." }
];

export default function BlogApp() {
    return (
        <div className="blog-app">
            <h1>My Blog</h1>
            <BlogList posts={samplePosts} />
        </div>
    );
}
