namespace LibGit2Sharp.Core
{
    /// <summary>
    /// 
    /// </summary>
    public enum GitErrorCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown = -1,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        NoMemory,
        /// <summary>
        /// 
        /// </summary>
        Os,
        /// <summary>
        /// 
        /// </summary>
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        Reference,
        /// <summary>
        /// 
        /// </summary>
        Zlib,
        /// <summary>
        /// 
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        Config,
        /// <summary>
        /// 
        /// </summary>
        Regex,
        /// <summary>
        /// 
        /// </summary>
        Odb,
        /// <summary>
        /// 
        /// </summary>
        Index,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        Net,
        /// <summary>
        /// 
        /// </summary>
        Tag,
        /// <summary>
        /// 
        /// </summary>
        Tree,
        /// <summary>
        /// 
        /// </summary>
        Indexer,
        /// <summary>
        /// 
        /// </summary>
        Ssl,
        /// <summary>
        /// 
        /// </summary>
        Submodule,
        /// <summary>
        /// 
        /// </summary>
        Thread,
        /// <summary>
        /// 
        /// </summary>
        Stash,
        /// <summary>
        /// 
        /// </summary>
        Checkout,
        /// <summary>
        /// 
        /// </summary>
        FetchHead,
        /// <summary>
        /// 
        /// </summary>
        Merge,
        /// <summary>
        /// 
        /// </summary>
        Ssh,
        /// <summary>
        /// 
        /// </summary>
        Filter,
        /// <summary>
        /// 
        /// </summary>
        Revert,
        /// <summary>
        /// 
        /// </summary>
        Callback,
        /// <summary>
        /// 
        /// </summary>
        CherryPick,
        /// <summary>
        /// 
        /// </summary>
        Describe,
        /// <summary>
        /// 
        /// </summary>
        Rebase,
        /// <summary>
        /// 
        /// </summary>
        Filesystem,
        /// <summary>
        /// a Patch related Error has occurred
        /// </summary>
        Patch,
        /// <summary>
        /// a WorkTree Related Error has occurred
        /// </summary>
        Worktree,
        /// <summary>
        /// An Error occurred during Sha1 Encryption
        /// </summary>
        Sha1,
        /// <summary>
        /// A Error occurred with the underlying Http call
        /// </summary>
        Http,
        /// <summary>
        /// An unrecoverable internal error has Occurred.
        /// </summary>
        Internal
    }
}
