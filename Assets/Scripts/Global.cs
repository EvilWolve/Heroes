using UnityEngine;
using System.Collections.Generic;

using Heroes.DataModel.Fiends;
using Heroes.DataModel.Slugs;

public class Global : MonoBehaviour
{
    private static Global _instance;
    public static Global Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject go = Instantiate(Resources.Load("General/Global") as GameObject);
                _instance = go.GetComponent<Global>();
            }

            return _instance;
        }
    }

    [SerializeField]
    private List<FiendData> fiends;
    [SerializeField]
    private List<SlugData> slugs;

    public Dictionary<FiendType, FiendData> fiendDict;
    public Dictionary<SlugType, SlugData> slugDict;

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        _instance = this;

        this.InitializeFiendData();

        this.InitializeSlugData();
    }

    private void InitializeFiendData()
    {
        this.fiendDict = new Dictionary<FiendType, FiendData>();
        FiendData fiend = null;

        for (int i = 0; i < this.fiends.Count; i++)
        {
            fiend = this.fiends[i];

            if (!this.fiendDict.ContainsKey(fiend.fiendType))
            {
                this.fiendDict.Add(fiend.fiendType, fiend);
            }
            else
            {
                Debug.LogError("Duplicate fiend data! Fiend: " + fiend.fiendType.ToString());
            }
        }
    }

    private void InitializeSlugData()
    {
        this.slugDict = new Dictionary<SlugType, SlugData>();
        SlugData slug = null;

        for (int i = 0; i < this.slugs.Count; i++)
        {
            slug = this.slugs[i];

            if (!this.slugDict.ContainsKey(slug.slugType))
            {
                this.slugDict.Add(slug.slugType, slug);
            }
            else
            {
                Debug.LogError("Duplicate slug data! Slug: " + slug.slugType.ToString());
            }
        }
    }
}
