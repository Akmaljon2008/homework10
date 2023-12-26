using System.Runtime.Intrinsics.X86;
using Domain.Models;
namespace Infrastructure.Services;

public class PostsServices
{
    List<Posts> posts = new List<Posts>();
    public List<Posts> GetPosts(){
        return posts;
    }
    public void AddPosts(Posts posts){
        this.posts.Add(posts);
    }
    public string UpdatePosts(Posts posts){
        foreach (var pe in this.posts)
        {
            if(pe.Id == posts.Id){
                pe.Title = posts.Title;
                pe.Description = posts.Description;
                pe.VoteAmount = posts.VoteAmount;
                pe.CreatedAi = posts.CreatedAi;
               return "Student deleted soccessfully";
            }
        }
        return "Post not found";
    }
    public string DeletePosts(int id){
        foreach (var pe in this.posts)
        {
            if(pe.Id == id){
                posts.Remove(pe);
                return "Student deleted successfully";
            }
        }
        return "Post not found";
    }
}
