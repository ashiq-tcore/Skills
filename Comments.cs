using System;

public static class CommentGenerator
{
    public static string GenerateComment(string skill)
    {
        if (string.IsNullOrWhiteSpace(skill))
            return "No skill provided.";

        return $"Great job developing your {skill} skill! Keep up the good work.";
    }
}