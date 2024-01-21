import { QaflabGhanatTemplatePage } from './app.po';

describe('QaflabGhanat App', function() {
  let page: QaflabGhanatTemplatePage;

  beforeEach(() => {
    page = new QaflabGhanatTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
