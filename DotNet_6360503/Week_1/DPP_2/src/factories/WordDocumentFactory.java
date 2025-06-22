package factories;

import documents.Documents;
import documents.WordDocument;

public class WordDocumentFactory extends DocumentFactory {
    @Override
    public Documents createDocument() {
        return new WordDocument();
    }
}